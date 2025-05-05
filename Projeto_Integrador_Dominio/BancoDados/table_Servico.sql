CREATE TABLE servico (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    valor INT NOT NULL,
    servicoCategoria INT NOT NULL
);

DROP TABLE servico;