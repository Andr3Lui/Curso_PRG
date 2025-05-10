CREATE TABLE servico (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    valor DECIMAL(10,2) NOT NULL
);

DROP TABLE servico;

INSERT INTO servico (nome, valor) VALUES ("Corte", "15.00"), ("Hidratação", "20.00"), ("Sobrancelha", "10.00");

SELECT * FROM servico;