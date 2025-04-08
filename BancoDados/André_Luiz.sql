CREATE TABLE IF NOT EXISTS cliente
(
id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR (100) NOT NULL, 
idade VARCHAR (3) NOT NULL ,
cidade  VARCHAR (50) NOT NULL,
saldo DECIMAL(10,2) NOT NULL
);

INSERT into cliente
(
nome, idade, cidade, saldo
)
values
('Carlos', '45', 'São Paulo', '2500.00'),
('Mariana', '32', 'Rio de Janeiro', '3200.50' ),
('Pedro' , '27', 'Belo Horizonte', '1500.75' ),
('Fernanda', '38', 'Curitiba', '4200.00' );

CREATE TABLE IF NOT EXISTS pedido
(
id INT PRIMARY KEY AUTO_INCREMENT,
cliente_id INT NOT NULL,
valor DECIMAL(10,2) NOT NULL,
data_pedido DATETIME NOT NULL,
FOREIGN KEY (cliente_id) REFERENCES cliente(id)
);

INSERT INTO pedido
(
cliente_id, valor, data_pedido
)
VALUES
('1', '500.00', '2024-03-10'),
('2', '1200.00', '2024-03-12'),
('3', '300.50','2024-03-15'),
('1', '800.00', '2024-03-18');
 
 drop table pedido;
 drop table cliente;

/*//EXERCICIO 1

*/
--
SELECT 
    *
FROM
    cliente
WHERE
    cidade = 'rio de janeiro';
    
--
SELECT 
    *
FROM
    cliente
WHERE
    saldo > 2000
ORDER BY saldo DESC;

--
SELECT 
    *
FROM
    cliente
WHERE
    idade > 30;

/*//EXERCICIO 2
*/
--
SELECT 
    *
FROM
    cliente
WHERE
    idade > 24 AND idade < 41;
    
--
SELECT 
    *
FROM
    cliente
WHERE
    nome LIKE 'F%';
    
--
SELECT 
    *
FROM
    cliente
WHERE
    cidade != 'São Paulo'
        AND cidade != 'Curitiba';
        
/*//EXERCICIO 3
*/
--
SELECT 
    COUNT(id)
FROM
    pedido; 
    
--
SELECT 
    AVG(valor)
FROM
    pedido;
    
--
SELECT 
    SUM(valor)
FROM
    pedido
GROUP BY cliente_id;

/*//EXERCICIO 4
*/
--
SELECT 
    pedido.id, cliente.nome AS cliente, pedido.valor
FROM
    pedido
        INNER JOIN
    cliente ON pedido.cliente_id = cliente.id;

--
SELECT 
    pedido.id, cliente.nome AS cliente, pedido.valor
FROM
    cliente
        LEFT JOIN
    pedido ON cliente.id = pedido.cliente_id;
    
/*//EXERCICIO 5 
*/
--
SELECT 
      pedido.id, cliente.nome AS cliente, pedido.valor
FROM
    pedido
 INNER JOIN
    cliente ON pedido.cliente_id = cliente.id
WHERE
    valor > (SELECT 
            AVG(valor)
        FROM
            pedido
            where categoria = 'Eletronico');
            
--
SELECT 
    pedido.id, cliente.nome, pedido.valor
FROM
    pedido
        INNER JOIN
    cliente ON pedido.cliente_id = cliente.id
    WHERE valor > 1000;
    
/*//EXERCICIO 6
*/
-- 
insert into cliente
(nome, cidade)
values
('Rafael','Porto Alegre');


UPDATE cliente
SET saldo = (saldo * 0.1) + saldo;


DELETE FROM pedido
WHERE valor < 500;



