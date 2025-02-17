#include <ESP32Lib.h>
#include <Ressources/Font6x8.h>

//pin configuration
const int redPin = 14;
const int greenPin = 19;
const int bluePin = 27;
const int hsyncPin = 0;
const int vsyncPin = 5;

//VGA Device
VGA3Bit vga;

void setup() {
  //initializing vga at the specified pins
  //vga.init(vga.MODE320x240, redPin, greenPin, bluePin, hsyncPin, vsyncPin);
  vga.init(vga.MODE400x300, redPin, greenPin, bluePin, hsyncPin, vsyncPin);
  //selecting the font
  vga.setFont(Font6x8);
  //displaying the text
  vga.println("Hello World!");
}

void loop() {
  // put your main code here, to run repeatedly:
}
