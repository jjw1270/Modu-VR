String receiveVal;  //"$RPY,00,00.00,00.00,00.00*0C"
int trash, noVal, xValNo, yValNo, zValNo;
int strLen;
String xVal, yVal, zVal;

void setup() {
  Serial.begin(115200);
  while(!Serial);
  Serial1.begin(115200);
  delay(10);

}

void loop() {
  if(Serial1.available()){
    receiveVal = Serial1.readStringUntil('\n');

    trash = receiveVal.indexOf(",");
    noVal = receiveVal.indexOf(",", trash+1);
    xValNo = receiveVal.indexOf(",", noVal+1);
    yValNo = receiveVal.indexOf(",", xValNo+1);
    zValNo = receiveVal.indexOf("*", yValNo+1);

    xVal = receiveVal.substring(noVal+1, xValNo);
    yVal = receiveVal.substring(xValNo+1, yValNo);
    zVal = receiveVal.substring(yValNo+1, zValNo);
    
    Serial.println(xVal + "  " + yVal + "  " + zVal);
    //Serial.println(receiveVal);
    delay(100);
  }
}
