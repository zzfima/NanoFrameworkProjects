#define LED_BUILTIN 2
#define BAUD_RATE 115200

String msg = "";

const int rellaysCount = 8;

//pinouts: https://randomnerdtutorials.com/esp32-pinout-reference-gpios/
int rellayPins[rellaysCount] = {21, 22, 23, 25, 26, 27, 32, 33};

int rellayStatuses[rellaysCount] = {0, 0, 0, 0, 0, 0, 0, 0};

void Blink(int frequencyMs)
{
  digitalWrite(LED_BUILTIN, HIGH);
  delay(frequencyMs);
  digitalWrite(LED_BUILTIN, LOW);
  delay(frequencyMs);
}

void printStartMessages()
{
  Blink(1000);
  Serial.println("Welcome to 8 relay commander");

  Serial.println("Commands list:");
  Serial.println("Rellay0=0");
  Serial.println("Rellay0=1");
  Serial.println("GetStatus");
  Blink(1000);
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
    digitalWrite(rellayPins[i], LOW);

  printStartMessages();
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

      // Print the message
      Serial.print("Message recieved: ");
      Serial.println(msg);

      if (msg == "GetStatus")
        SendStatus();
      else
      {
        // debug
        Serial.println(msg[6]);
        Serial.println(msg[8]);

        // message format: "Rellay0=1")
        int rellayNumber = (int)(msg[6] - '0');
        int rellayStatus = (int)(msg[8] - '0');

        Serial.println(rellayNumber);
        Serial.println(rellayStatus);

        if (rellayStatus == 1)
        {
          digitalWrite(rellayPins[rellayNumber], HIGH);
          rellayStatuses[rellayNumber] = 1;
          Serial.print("Set relay HIGH ");
          Serial.print(rellayNumber);
          Serial.print(" status=");
          Serial.println(rellayStatus);
        }
        else if (rellayStatus == 0)
        {
          digitalWrite(rellayPins[rellayNumber], LOW);
          rellayStatuses[rellayNumber] = 0;
          Serial.print("Set relay LOW ");
          Serial.print(rellayNumber);
          Serial.print(" status=");
          Serial.println(rellayStatus);
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