CREATE TABLE produto (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    valor DECIMAL(10,2) NOT NULL,
    estoque INT NOT NULL
);

DROP TABLE produto;
insert into produto(nome, valor, estoque) values("pente", "3.00 ", "12"), ("Shampoo", "12.00 ", "20"), ("Condicionador", "10.00", "20"); 



select * from produto