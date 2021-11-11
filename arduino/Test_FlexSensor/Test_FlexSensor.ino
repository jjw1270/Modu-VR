int flexpin = 0;


void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  int flexVal;
  flexVal = analogRead(flexpin);

  Serial.print("sensor : ");
  Serial.println(flexVal);
}
