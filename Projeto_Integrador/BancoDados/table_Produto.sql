CREATE TABLE produto (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    valor DECIMAL(10,2) NOT NULL,
    estoque INT NOT NULL
);

DROP TABLE produto;

insert into produto(nome, valor, estoque) 
values
("Gelatina", 12.00, "25"),
("Hidratante Labia", 5.00, "31"),
("Maquiagens", 10.00, "45"),
("Protetor térmico", 14.50, "6"),
("Cremes", 12.75, "22"),
("Reparador de pontas", 12.90, "14"),
("Gel", 7.99, "15"); 

select * from produto;