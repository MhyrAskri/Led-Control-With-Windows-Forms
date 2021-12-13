int led = 3;
int data;
int blink_count;
int blink_speed;

void setup() {

  pinMode(led , OUTPUT);
  Serial.begin(9600);
  
}

void loop() {

  while(Serial.available()) {

    data = Serial.parseInt();
    blink_count = Serial.parseInt();
    blink_speed = Serial.parseInt();

    if(data == 1) {

      digitalWrite(led , 1);
      
    } else if(data == 2) {

      digitalWrite(led , 0);
      
    } else if(data == 3) {

      for(int i = 1 ; i <= blink_count ; i++) {

        digitalWrite(led , 1);
        delay(blink_speed);
        digitalWrite(led , 0);
        delay(blink_speed);
        
      }
      
    }
    
  }

  delay(1);
  
}
