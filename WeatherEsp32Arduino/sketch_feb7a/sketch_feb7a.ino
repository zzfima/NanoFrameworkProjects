#include <WiFi.h>
#include <HTTPClient.h>
#include <ArduinoJson.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>
#include <Wire.h>

#define SCREEN_WIDTH 128  // OLED display width, in pixels
#define SCREEN_HEIGHT 64  // OLED display height, in pixels

#define OLED_RESET -1        // Reset pin # (or -1 if sharing Arduino reset pin)
#define SCREEN_ADDRESS 0x3D  //0x3D ///< See datasheet for Address; 0x3D for 128x64, 0x3C for 128x32

#define SDA_PIN 21
#define SCL_PIN 22

// Declaration for an SSD1306 display connected to I2C (SDA, SCL pins)
Adafruit_SSD1306 display(SCREEN_WIDTH, SCREEN_HEIGHT, &Wire, OLED_RESET);

//Put your WiFi Credentials here
const char* ssid = "";
const char* password = "";

//URL Endpoint for the API
String URL = "http://api.openweathermap.org/data/2.5/weather?";
String ApiKey = "";

// Yosef Katran
String lat = "";
String lon = "";

void setup() {
  Serial.begin(115200);
  
  Wire.begin(SDA_PIN, SCL_PIN);  //init OLED
  display.setTextSize(1);
  display.setTextColor(WHITE);
  display.setCursor(10, 10);

  WiFi.begin(ssid, password);

  while (WiFi.status() != WL_CONNECTED) {
    delay(1000);
    Serial.print(".");
  }

  Serial.println("");
  Serial.println("WiFi connected.");
  Serial.println("IP address: ");
  Serial.println(WiFi.localIP());
}

void loop() {
  // wait for WiFi connection
  if (WiFi.status() == WL_CONNECTED) {

    HTTPClient http;

    //Set HTTP Request Final URL with Location and API key information
    http.begin(URL + "lat=" + lat + "&lon=" + lon + "&units=metric&appid=" + ApiKey);

    // start connection and send HTTP Request
    int httpCode = http.GET();

    display.clearDisplay();

    // httpCode will be negative on error
    if (httpCode > 0) {

      //Read Data as a JSON string
      String JSON_Data = http.getString();
      Serial.println(JSON_Data);

      //Retrieve some information about the weather from the JSON format
      DynamicJsonDocument doc(2048);
      deserializeJson(doc, JSON_Data);
      JsonObject obj = doc.as<JsonObject>();

      //Display the Current Weather Info
      const char* description = obj["weather"][0]["description"].as<const char*>();
      const float temp = obj["main"]["temp"].as<float>();
      const float humidity = obj["main"]["humidity"].as<float>();

      display.println(description);
      display.setCursor(0, 1);
      display.println(temp);
      display.println(" C, ");
      display.println(humidity);
      display.println(" %");
    } else {
      Serial.println("Error!");
      display.clearDisplay();
      display.println("Can't Get DATA!");
    }

    display.display();

    http.end();
  }

  //Wait for 30 seconds
  delay(30000);
}