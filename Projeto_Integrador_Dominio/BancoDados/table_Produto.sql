CREATE TABLE produto (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    estoque INT NOT NULL,
    produtoCategoria INT NOT NULL
);

DROP TABLE produto;