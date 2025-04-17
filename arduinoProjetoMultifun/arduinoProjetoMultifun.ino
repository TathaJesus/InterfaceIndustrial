#include <DHT.h>

#define DHTPIN 4       // DHT11 está no pino digital 2
#define DHTTYPE DHT11
DHT dht(DHTPIN, DHTTYPE);

#define LED_VERMELHO 12
#define LED_AZUL 13

#define POT_PIN A0

String comando = "";

void setup() {
  Serial.begin(9600);
  dht.begin();

  pinMode(LED_VERMELHO, OUTPUT);
  pinMode(LED_AZUL, OUTPUT);
}

void loop() {
  // Envia dados do potenciômetro e temperatura a cada 2 segundos
  int valorPot = analogRead(POT_PIN);
  float temperatura = dht.readTemperature();
  float umidade = dht.readHumidity();

  // Envia dados para o app
  Serial.print("POT:");
  Serial.print(valorPot);
  Serial.print(" TEMP:");
  Serial.print(temperatura);
  Serial.print("C HUM:");
  Serial.print(umidade);
  Serial.println("%");

  // Lê comandos do app
  if (Serial.available()) {
    char caractere = Serial.read();
    if (caractere == '\n') {
      processarComando(comando);
      comando = "";  // limpa o comando após o processamento
    } else {
      comando += caractere;
    }
  }

  delay(2000); // espera 2 segundos
}

void processarComando(String cmd) {
  cmd.trim(); // remove espaços e quebras

  if (cmd == "LED_VERMELHO_ON") {
    digitalWrite(LED_VERMELHO, HIGH);
  } else if (cmd == "LED_VERMELHO_OFF") {
    digitalWrite(LED_VERMELHO, LOW);
  } else if (cmd == "LED_AZUL_ON") {
    digitalWrite(LED_AZUL, HIGH);
  } else if (cmd == "LED_AZUL_OFF") {
    digitalWrite(LED_AZUL, LOW);
  }
}
