//Adafruit QT Py ESP32-C3

#define LED_BUILTIN 8
#define BAUD_RATE 115200
#define GPIO0 0
#define GPIO1 1
#define GPIO2 2
#define GPIO3 3
#define GPIO4 4
#define GPIO5 5
#define GPIO6 6
#define GPIO7 7

String msg = "";

const int rellaysCount = 8;

/*
  Commands list:
  Rellay0=0
  Rellay0=1
  GetStatus
*/

//pinouts: https://randomnerdtutorials.com/esp32-pinout-reference-gpios/
int rellayPins[rellaysCount] = {GPIO0, GPIO1, GPIO2, GPIO3, GPIO4, GPIO5, GPIO6, GPIO7};

int rellayStatuses[rellaysCount] = {0, 0, 0, 0, 0, 0, 0, 0};

void Blink(int frequencyMs)
{
  digitalWrite(LED_BUILTIN, LOW);
  delay(frequencyMs);
  digitalWrite(LED_BUILTIN, HIGH);
  delay(frequencyMs);
}

// the setup function runs once when you press reset or power the board
void setup()
{
  // initialize digital pin LED_BUILTIN as an output.
  pinMode(LED_BUILTIN, OUTPUT);
  // Start the Serial Monitor at a baud rate of 115200
  Serial.begin(BAUD_RATE);

  // relays pins setup
  for (int i = 0; i < rellaysCount; i++)
    pinMode(rellayPins[i], OUTPUT);

  // turn off all relays
  for (int i = 0; i < rellaysCount; i++)
    digitalWrite(rellayPins[i], HIGH);

  Blink(1000);
}

void SendStatus()
{
  String status = "STATUSES: ";

  for (int i = 0; i < rellaysCount; i++)
  {
    if (rellayStatuses[i] == 0)
      status += "0";
    else
      status += "1";
  }

  Serial.println(status);
}

// the loop function runs over and over again forever
void loop()
{
  while (Serial.available())
  {
    char incomingChar = Serial.read(); // Read each character from the buffer

    if (incomingChar == '\n')
    { // Check if the user pressed Enter (new line character)
      if (msg == "GetStatus")
        SendStatus();
      else
      {
        // message format: "Rellay0=1")
        int rellayNumber = (int)(msg[6] - '0');
        int rellayStatus = (int)(msg[8] - '0');

        if (rellayStatus == 1)
        {
          digitalWrite(rellayPins[rellayNumber], LOW);
          rellayStatuses[rellayNumber] = 1;
        }
        else if (rellayStatus == 0)
        {
          digitalWrite(rellayPins[rellayNumber], HIGH);
          rellayStatuses[rellayNumber] = 0;
        }
      }
      // Clear the message buffer for the next input
      msg = "";
    }
    else
    {
      // Append the character to the message string
      msg += incomingChar;
    }
  }
}