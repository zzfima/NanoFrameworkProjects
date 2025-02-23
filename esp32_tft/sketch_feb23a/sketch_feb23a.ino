#include <ArduinoJson.h>
#include <ArduinoJson.hpp>
#include <WiFi.h>
#include <HTTPClient.h>

#include <Adafruit_GFX.h>
#include <Adafruit_GrayOLED.h>
#include <Adafruit_SPITFT.h>
#include <Adafruit_SPITFT_Macros.h>
#include <gfxfont.h>

#include <Wire.h>
#include "credentials.h"
// ########################################################
// ########################################################
// #
// #              Sketch:  Draw_Centered_String
// #
// #                Date:  1-22-24
// #
// #  This sketch is draws a centered text string on the
// #                MSP2807 ILI9341 TFT Display
// #
// # This sketch uses an ILI9341 Constructor of the form:
// #
// # Adafruit_ILI9341 tft = Adafruit_ILI9341(TFT_CS, TFT_DC, TFT_MOSI, TFT_SCK, TFT_RST, TFT_MISO);
// #
// #   TFT_MISO and TFT_SCK pin connections must also be defined and
// #      connected to the ESP32 for this sketch to work
// #
// #      Microprocessor:  ESP32 Dev Module
// #                       30-Pin, ESP32 DEVKIT V1
// #                       www.doit.am
// #
// #           Tool Kit:  Board Model:  ESP32 Dev Module
// #                      Serial Port:  COM4
// #
// #             Display:  MSP2807
// #                       TFT LCD, 320 x 240 Pixels
// #          Control IC:  ILI9341
// #
// #    Silicon Labs CP210X Driver is used to connect ESP32 to COM4
// #
// ####################################################################

// ####################################################################
// #
// #     Define standard boilerplate Bodmer pin connections between the
// #     ILI9341 display and the ESP32 uP driving it.
// #
// #     This is the same boilerplate pin mapping as used in the User_Setup
// #     Setup1_ILI9341 in the TFT_eSPI Library
// #
// ####################################################################

#define TFT_CS 15  // TFT CS  pin conn to ESP32 uP pin 15  Brown
#define TFT_RST 4  // TFT RST pin conn to ESP32 uP pin  4  Red
#define TFT_DC 2   // TFT DC  pin conn to ESP32 uP pin  2  Orange

// ####################################################################
// #
// #    Other standard, additional boilerplate Bodmer pin connections
// #    between the ILI9341 display and the ESP32 uP are listed below
// #
// ####################################################################

#define TFT_MOSI 23  // TFT MOSI pin conn to ESP32 uP pin 23  Yellow
#define TFT_SCK 18   // TFT SCK pin conn to ESP32 uP pin 18   Green

#define TFT_MISO 19  // TFT MISO pin conn to ESP32 uP pin 19 Gray - Used

//  #define TFT_LED  3.3V     // TFT LED conn to ESP32 uP pin 3.3V

// ####################################################################
// ####################################################################

#include <SPI.h>

#include <Adafruit_GFX.h>      // include Adafruit graphics library
#include <Adafruit_ILI9341.h>  // include Adafruit ILI9341 TFT library

// initialize the ILI9341 TFT library

Adafruit_ILI9341 display = Adafruit_ILI9341(TFT_CS, TFT_DC, TFT_MOSI, TFT_SCK, TFT_RST, TFT_MISO);

// ####################################################################
// ####################################################################

void displayWeather();
void displayTime();

void setup(void) {
  display.begin();
  display.setRotation(1);
  display.fillScreen(ILI9341_BLACK);

  //init wifi
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    delay(1000);
  }

  display.setTextColor(ILI9341_MAGENTA);
  display.setCursor(0, 40);
  display.setTextSize(5);
  display.println("Weather");
  display.println("Station");
}

void loop() {
  if (WiFi.status() == WL_CONNECTED) {
    display.fillScreen(ILI9341_BLACK);
    display.setCursor(0, 1);

    displayTime();
    displayWeather();
    delay(100000);
  }
}

void displayTime() {
  HTTPClient http;

  // Set HTTP Request Final URL with Location information
  http.begin(URLTime + "latitude=" + lat + "&longitude=" + lon);

  // Start connection and send HTTP Request
  int httpCode = http.GET();

  // httpCode will be negative on error
  if (httpCode > 0) {
    // Read Data as a JSON string
    String JSON_Data = http.getString();
    // Retrieve some information about the time from the JSON format
    DynamicJsonDocument doc(1024);
    deserializeJson(doc, JSON_Data);
    JsonObject obj = doc.as<JsonObject>();
    // Display the Current Time Info
    int day = obj["day"];
    int month = obj["month"];
    int year = obj["year"];

    int hour = obj["hour"];
    int minute = obj["minute"];

    display.setTextColor(ILI9341_MAGENTA);
    display.setTextSize(4);
    display.print(day);
    display.print(".");
    display.print(month);
    display.print(".");
    display.println(year);

    display.print(hour);
    display.print(":");
    display.print(minute);
  } else {
    display.fillScreen(ILI9341_BLACK);
    display.println("Can't Get DATA!");
  }
  http.end();
}

void displayWeather() {
  HTTPClient http;

  // Set HTTP Request Final URL with Location and API key information
  http.begin(URLWeather + "lat=" + lat + "&lon=" + lon + "&units=metric&appid=" + ApiKey);

  // start connection and send HTTP Request
  int httpCode = http.GET();

  // httpCode will be negative on error
  if (httpCode > 0) {
    // Read Data as a JSON string
    String JSON_Data = http.getString();
    // Retrieve some information about the weather from the JSON format
    DynamicJsonDocument doc(2048);
    deserializeJson(doc, JSON_Data);
    JsonObject obj = doc.as<JsonObject>();
    // Display the Current Weather Info
    const char* description = obj["weather"][0]["description"].as<const char*>();
    const char* place = obj["name"].as<const char*>();
    const char* country = obj["sys"]["country"].as<const char*>();

    const float temp = obj["main"]["temp"].as<float>();
    const float humidity = obj["main"]["humidity"].as<float>();

    display.setTextColor(ILI9341_YELLOW);
    display.setTextSize(2);
    display.print("now ");
    display.print(description);
    display.println(" at");
    display.print(place);
    display.print(", ");
    display.println(country);

    display.setTextColor(ILI9341_YELLOW);
    display.setTextSize(3);
    display.println("");
    display.print(temp);
    display.println(" C");
    display.print(humidity);
    display.println(" %");
  } else {
    display.fillScreen(ILI9341_BLACK);
    display.println("Can't Get DATA!");
  }
  http.end();
}