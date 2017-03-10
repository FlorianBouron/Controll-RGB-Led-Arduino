
int message = 0;   //  This will hold one byte of the serial message
int LEDBlue = 3;
int LEDGreen = 5;
int LEDRed = 6;
int valueBlue = 255;
int valueGreen = 0;
int valueRed = 0;


void setup()
{  
  Serial.begin(9600);  //set serial to 9600 baud rate
  pinMode(LEDBlue, OUTPUT);
  pinMode(LEDGreen, OUTPUT);
  pinMode(LEDRed, OUTPUT);
}

void loop(){
  
  // Color the led
  analogWrite(LEDBlue,valueBlue);
  analogWrite(LEDGreen,valueGreen);
  analogWrite(LEDRed,valueRed);
  
  if (Serial.available() > 0) //  Check to see if there is a new message
  { 
    message = Serial.read();    //  Put the serial input into the message
    
    if (message == 'B')  //  Receive blue value
    {
      valueBlue = Serial.read();
    }
    if (message == 'G')  //  Receive green value
    {
      valueGreen = Serial.read();
    }
    if (message == 'R')  //  Receive red value
    {
      valueRed = Serial.read();
    }
    if (message == 'z')  //  If a lowercase z is received
    { 
      Serial.println("HELLO FROM ARDUINO");  // Send back Arduino is here
    }
  }
}

