/*
connect STLink to board:

connect wires:
stlink      st board
2 swclck    swclck
4 swdio     swio
6 grnd      grnd
8 3.3       3v3

using stlink:
install driver: https://www.st.com/en/development-tools/stsw-link009.html?dl=8L7EtNWUxsol2dsVW0h01A%3D%3D%2Cc3exna%2BFt2eIFIF0sVJpihdBsAbU4UXawTUJflEkQi9hCIY8z3IA8UkgJoKE9v0%2FahyCrvrQTqP0s6LlVisUiazkbNzT3L4l%2BUwaR1lZW0iBGS4n6IDORv7OpGaOleAofw6SDXwVzWX%2BUDKTLkKU37ecCm2u%2BVOrxmLMYltA9kWUjNVK0vGd3LX4H80kQyhJJDpVoTJSrcq1VFUAQ8s8qBA8C8dTkjrgTd5vGa%2BwuLPk%2FIhqvJaI%2BV33avR4joxFP8YWAyR5tfGRQjhRTa3quIDLhgex1JzWfXEHz7uVDj3%2F4NNaFp66P2NgE%2BoPy9d1#get-software
install arduino board: STM32f1xx
see: https://www.youtube.com/watch?v=saolJ_7E7hc&ab_channel=CuriousScientist
upload method - stlink



  BluePill/UsingSTLink
  Simplest example possible: Programming an ARM Cortex-M3 STM32F103C8T6 Blue Pill with an ST Link v2 programmer and the Arduino IDE

  For info and circuit diagrams see https://github.com/tardate/LittleArduinoProjects/tree/master/ARM/STM32F103C8T6/BluePill/UsingSTLink

 */

const int LED_PIN = PC13;
const int BASE_FREQ = 100;

void setup() {
  pinMode(LED_PIN, OUTPUT);
}

void loop() {
  static boolean output = HIGH;

  digitalWrite(LED_PIN, output);

  if (output) {
    delay(BASE_FREQ);
  } else {
    delay(BASE_FREQ * 3);
  }

  output = !output;
}
