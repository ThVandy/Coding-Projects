/*This was made in Adruino for ESP32 wifi enabled boards to connect to the Streamer.bot.

It will take a custom message from the built in Streamer.bot websocket server and convert it into a string for an
ESP32 websocket client. From there you can use the data payload sent to continue to run more code on your ESP32 boards
to control displays, motors, servos and anything else within the Arduino libraries. 
*/


// Constants
#include <ArduinoWebsockets.h>
#include <WiFi.h>
#include <ArduinoJson.h>

const char* ssid = "XXXX"; //Enter SSID
const char* password = "XXXX"; //Enter Password
const char* websockets_server_host = "XXXX"; //Enter server adress
const uint16_t websockets_server_port = XXXX; // Enter server port

// Make variables for the Json documents
JsonDocument recieve;
JsonDocument subscribe;

// Variable for serializing JSON
char output[256]; 

using namespace websockets;


// Connect to Wifi on ESP32
WebsocketsClient client;
void setup() {
    Serial.begin(115200);
     // Connect to wifi
  WiFi.begin(ssid, password);

  // Wait some time to connect to wifi
  for (int i = 0; i < 10 && WiFi.status() != WL_CONNECTED; i++) {
    Serial.print(".");
    delay(1000);
  }

  // Check if connected to wifi
  if (WiFi.status() != WL_CONNECTED) {
    Serial.println("No Wifi!");
    return;
  }
  // Prints to serial your IP for checking against the server if running multipul
  Serial.println("Connected to Wifi, Connecting to server.");
  Serial.println(WiFi.localIP());

  // try to connect to Websockets server
  bool connected = client.connect(websockets_server_host, websockets_server_port, "/");
  if (connected) {
    Serial.println("Connected!");
  } else {
    Serial.println("Not Connected!");
  }
  
  /* Subscribing to the Websocket Server
      Using the subscribe JsonDocument

      This is currently set up for recieving all custom events

    */
    subscribe["request"] = "Subscribe";
    subscribe["id"] = "my-subscribe-id";
    subscribe["events"]["general"][0] = "Custom";
    serializeJson(subscribe, Serial);
    serializeJson(subscribe, output);
    client.send(output);
}

void loop() {
	 // let the websockets client check for incoming messages
    if (client.available()) {
      client.poll();

   
    } 
     // run callback when messages are received
    client.onMessage([&](WebsocketsMessage message) {
    Serial.println("Got Message : ");
    Serial.println(message.data());

    // Deserialize the JSON document
    DeserializationError error = deserializeJson(recieve, message.data());

    // Test if parsing succeeds.
    if (error) {
      Serial.print(F("deserializeJson() failed: "));
      Serial.println(error.f_str());
      return;
    }

    // Pulling the data from the server
    const char* data = recieve["data"]["data"];
    

    // Printing the "request" from the server
    Serial.print("Decoded : ");
    Serial.println(data);

    String decode(data);
	delay(100);
	
	//You can use the string to check against and preform other actions
	//if (decode == "YourServerMessage") {
	//	Do the thing
	//  }
	
}