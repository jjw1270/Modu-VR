const int flexpin_0 = A0;
const int flexpin_1 = A1;
const int flexpin_2 = A2;
const int flexpin_3 = A3;
const int flexpin_6 = A6;
const int flexpin_7 = A7;
const int flexpin_8 = A8;
const int flexpin_9 = A9;
const int flexpin_10 = A10;

int flexVal_0;
int flexVal_1;
int flexVal_2;
int flexVal_3;
int flexVal_6;
int flexVal_7;
int flexVal_8;
int flexVal_9;
int flexVal_10;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(flexpin_0, INPUT);
  pinMode(flexpin_1, INPUT);
  pinMode(flexpin_2, INPUT);
  pinMode(flexpin_3, INPUT);
  pinMode(flexpin_6, INPUT);
  pinMode(flexpin_7, INPUT);
  pinMode(flexpin_8, INPUT);
  pinMode(flexpin_9, INPUT);
  pinMode(flexpin_10, INPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  flexVal_0 = analogRead(flexpin_0);
  flexVal_1 = analogRead(flexpin_1);
  flexVal_2 = analogRead(flexpin_2);
  flexVal_3 = analogRead(flexpin_3);
  flexVal_6 = analogRead(flexpin_6);
  flexVal_7 = analogRead(flexpin_7);
  flexVal_8 = analogRead(flexpin_8);
  flexVal_9 = analogRead(flexpin_9);
  flexVal_10 = analogRead(flexpin_10);

  Serial.println(String(flexVal_0)+"  "+ String(flexVal_1)+"  "+ String(flexVal_2)+"  "+
    String(flexVal_3)+"  "+ String(flexVal_6)+"  "+ String(flexVal_7)+"  "+
    String(flexVal_8)+"  "+ String(flexVal_9)+"  "+ String(flexVal_10));
  delay(100);
}
