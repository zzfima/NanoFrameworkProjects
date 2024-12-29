#define LED_BUILTIN 2
#define BAUD_RATE 115200
String receivedMessage = "";  // Variable to store the complete message

// the setup function runs once when you press reset or power the board
void setup() {
  // initialize digital pin LED_BUILTIN as an output.
  pinMode(LED_BUILTIN, OUTPUT);
  // Start the Serial Monitor at a baud rate of 115200
  Serial.begin(BAUD_RATE);
}

void Blink(int frequencyMs) {
  digitalWrite(LED_BUILTIN, HIGH);
  delay(frequencyMs);
  digitalWrite(LED_BUILTIN, LOW);
  delay(frequencyMs);
}

// the loop function runs over and over again forever
void loop() {
  while (Serial.available()) {
    char incomingChar = Serial.read();  // Read each character from the buffer

    if (incomingChar == '\n') {  // Check if the user pressed Enter (new line character)

      // Print the message
      Serial.print("You sent: ");
      Serial.println(receivedMessage);

      // Clear the message buffer for the next input
      receivedMessage = "";
      Blink(500);

    } else {
      // Append the character to the message string
      receivedMessage += incomingChar;
    }  // wait for a second
  }
}
