const int flexpin_1 = A1;
const int flexpin_2 = A2;
const int flexpin_3 = A3;
const int flexpin_4 = A4;

int flexVal_1;
int flexVal_2;
int flexVal_3;
int flexVal_4;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(flexpin_1, INPUT);
  pinMode(flexpin_2, INPUT);
  pinMode(flexpin_3, INPUT);
  pinMode(flexpin_4, INPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  flexVal_1 = analogRead(flexpin_1);
  flexVal_2 = analogRead(flexpin_2);
  flexVal_3 = analogRead(flexpin_3);
  flexVal_4 = analogRead(flexpin_4);

  Serial.println(String(flexVal_1)+"  "+ String(flexVal_2)+"  "+ 
                  String(flexVal_3)+"  "+ String(flexVal_4));
  delay(100);
}
