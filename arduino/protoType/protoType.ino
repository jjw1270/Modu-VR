const int flexpin_0 = A0;
const int flexpin_1 = A1;
const int flexpin_2 = A2;
const int flexpin_3 = A3;
const int flexpin_6 = A6;
const int flexpin_7 = A7;
const int flexpin_8 = A8;
const int flexpin_9 = A9;

int flexVal_1up;
int flexVal_1down;
int flexVal_2up;
int flexVal_2down;
int flexVal_3up;
int flexVal_3down;
int flexVal_4up;
int flexVal_4down;



String receiveVal;  //"$RPY,00,00.00,00.00,00.00*0C"
int trash, noVal, xValNo, yValNo, zValNo;
int strLen;
String xVal, yVal, zVal;

void setup() {
  pinMode(flexpin_0, INPUT);
  pinMode(flexpin_1, INPUT);
  pinMode(flexpin_2, INPUT);
  pinMode(flexpin_3, INPUT);
  pinMode(flexpin_6, INPUT);
  pinMode(flexpin_7, INPUT);
  pinMode(flexpin_8, INPUT);
  pinMode(flexpin_9, INPUT);
  
  Serial.begin(115200);
  while(!Serial);
  Serial1.begin(115200);
  delay(10);
}

void loop() {
  flexVal_1up = analogRead(flexpin_6);
  flexVal_1down = analogRead(flexpin_7);
  flexVal_2up = analogRead(flexpin_8);
  flexVal_2down = analogRead(flexpin_9);
  flexVal_3up = analogRead(flexpin_2);
  flexVal_3down = analogRead(flexpin_1);
  flexVal_4up = analogRead(flexpin_0);
  flexVal_4down = analogRead(flexpin_3);
  
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
    
    Serial.println(xVal + "  " + yVal + "  " + zVal + "  ||  " +
        String(flexVal_1up)+"  "+ String(flexVal_1down)+"  "+ String(flexVal_2up)+"  "+
        String(flexVal_2down)+"  "+ String(flexVal_3up)+"  "+ String(flexVal_3down)+"  "+
        String(flexVal_4up)+"  "+ String(flexVal_4down));
    //Serial.println(receiveVal);
    delay(100);
  }
}
