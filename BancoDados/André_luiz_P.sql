CREATE TABLE IF NOT EXISTS produto (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    categoria VARCHAR(50) NOT NULL,
    preco DECIMAL NOT NULL,
    estoque INT NOT NULL,
    id_fornecedor INT NOT NULL,
    FOREIGN KEY (id_fornecedor) REFERENCES fornecedor (id)
);
DROP TABLE produto;

INSERT INTO produto
(
nome, categoria, preco, estoque, id_fornecedor
)
VALUES
('Celular X', 'Eletrônico', '2500.00', '30', '1'),
('Notebook Y', 'Eletrônico', '4800.00', '15', '2'),
('Mesa de Madeira', 'Móveis', '750.00', '10', '3'),
('Cadeira Z', 'Móveis', '300.00', '25', '3'),
('TV 50"', 'Eletrônico', '3500.00', '8', '1');

CREATE TABLE IF NOT EXISTS fornecedor (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    cidade VARCHAR(50) NOT NULL
); 
DROP TABLE fornecedor;

INSERT INTO fornecedor 
(
	nome, cidade
) 
VALUES 
('TechBrasil', 'São Paulo'),
('CompuTech', 'Rio de Janeiro'),
('Móveis&Co', 'Curitiba');

CREATE TABLE IF NOT EXISTS pedido (
    id INT PRIMARY KEY AUTO_INCREMENT,
    quantidade INT NOT NULL,
    data_pedido DATETIME NOT NULL,
    id_produto INT NOT NULL,
    id_cliente INT NOT NULL,
    FOREIGN KEY (id_produto) REFERENCES produto (id),
    FOREIGN KEY (id_cliente) REFERENCES cliente (id)
);
DROP TABLE pedido;

INSERT INTO pedido
(
	id_produto, quantidade, data_pedido, id_cliente
)
VALUES
 ('1', '2', '2024-03-10', '1'),
 ('3', '1', '2024-03-11', '2'),
 ('2', '1', '2024-03-15', '3'),
 ('5', '3', '2024-03-18', '1'),
 ('4', '4', '2024-03-20', '4');



CREATE TABLE IF NOT EXISTS cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    cidade VARCHAR(50) NOT NULL,
    idade INT NOT NULL
);
DROP TABLE cliente;

INSERT INTO cliente
(
	nome, cidade, idade
) 
VALUES 
('João Silva', 'São Paulo', '35'),
('Maria Santos', 'Belo Horizonte', '28'),
('Carlos Lima', 'Rio de Janeiro', '42'),
('Fernanda Rocha', 'Curitiba', '30'),
('André Luiz', 'São Paulo', '21'),
('Agatha Abreu', 'São paulo', '26'),
('Fernando Queiroz', 'Belo Horizonte', '47'),
('Maria Aparecida', 'Rio de Janeiro', '64');


/*// CONSULTAS E FILTROS
*/
-- 1
SELECT 
    nome,
    categoria,
    preco
FROM
    produto
WHERE
    categoria = 'Eletronico'
        AND preco > 3000
ORDER BY (preco) DESC;

-- 2
SELECT 
    *
FROM
    cliente
WHERE
    cidade <> 'São Paulo' AND idade > 29;

-- 3
SELECT 
 *
FROM
    pedido 

WHERE
    data_pedido BETWEEN '2024-03-10' AND '2024-03-15'
ORDER BY data_pedido ASC;

-- 4
SELECT 
    id, nome, estoque
FROM
    produto
WHERE
    estoque < 10;

-- 5
SELECT 
    *
FROM
    fornecedor
WHERE
    cidade != 'Rio de Janeiro'
        AND nome LIKE 'T%';

/*// AGREGAÇÃO E AGRUPAMENTO
*/
-- 1
SELECT 
    categoria, avg(preco) AS Média_Categoria
FROM
    produto
GROUP BY categoria; 

-- 2
SELECT 
    cliente.nome, COUNT(pedido.id) AS quantidade_pedido
FROM
    pedido
        INNER JOIN
    cliente ON pedido.id_cliente = cliente.id
GROUP BY id_cliente;

-- 3
SELECT 
    categoria, SUM(estoque) AS estoque
FROM
    produto
group BY categoria;

-- 4 
SELECT 
 pedido.id, cliente.nome, produto.nome as produto, quantidade
FROM
    pedido
        INNER JOIN
    produto ON pedido.id_produto = produto.id
        INNER JOIN
    cliente ON pedido.id_cliente = cliente.id
order by quantidade desc 
limit 1;

-- 5
SELECT 
    COUNT(id) AS clientes, cidade
FROM
    cliente
GROUP BY cidade
ORDER BY id ASC;

/*//JUNÇÕES
*/
-- 1
SELECT 
	fornecedor.nome AS fornecedor,
    produto.nome AS produto
    
FROM
    produto
inner join 
fornecedor on produto.id_fornecedor = fornecedor.id;

-- 2
SELECT 
    pedido.id AS pedido,
    cliente.nome AS cliente,
    produto.nome AS produto,
    pedido.data_pedido
FROM
    pedido
        INNER JOIN
    cliente ON pedido.id_cliente = cliente.id
        INNER JOIN
    produto ON pedido.id_produto = produto.id
ORDER BY data_pedido ASC;

-- 3
SELECT 
    pedido.id AS pedido,
    cliente.nome AS cliente,
    produto.nome AS produto,
    fornecedor.nome AS fornecedor
FROM
    pedido
        INNER JOIN
    cliente ON pedido.id_cliente = cliente.id
        INNER JOIN
    produto ON pedido.id_produto = produto.id
	inner join 
    fornecedor on produto.id_fornecedor = fornecedor.id
order by pedido.id asc;

-- 4
SELECT 
    pedido.id AS pedido,
    cliente.nome AS cliente,
    produto.nome AS produto,
    SUM(pedido.quantidade) AS quantidade
FROM
    pedido
        INNER JOIN
    cliente ON pedido.id_cliente = cliente.id
        INNER JOIN
    produto ON pedido.id_produto = produto.id
GROUP BY produto.nome;

/*//SUBCONSULTAS E MODIFICAÇÃO DE DADOS

*/

-- 1
SELECT 
    nome, categoria, preco
FROM
    produto
WHERE
    preco > (SELECT 
            AVG(preco)
        FROM
            produto
        WHERE
            categoria = 'Eletrônico')
        AND preco > (SELECT 
            AVG(preco)
        FROM
            produto
        WHERE
            categoria = 'Móveis')
        OR preco > (SELECT 
            AVG(preco)
        FROM
            produto
        WHERE
            categoria = 'Móveis')
        AND preco > (SELECT 
            AVG(preco)
        FROM
            produto
        WHERE
            categoria = 'Eletrônico')
      
;

-- 2
UPDATE produto 
SET 
    preco = (preco * 0.1) + preco
WHERE
    categoria = 'eletronico';
    
-- 3 
DELETE FROM pedido 
WHERE
    id_cliente = (SELECT 
        id
    FROM
        cliente
    
    WHERE
        cidade = 'curitiba');

-- 4 
INSERT INTO cliente
(
nome, cidade, idade
)
VALUES
('Ricardo Lopes', 'Porto Alegre', '38');

-- 5
INSERT INTO pedido
(
id_produto, quantidade, data_pedido, id_cliente
)
VALUES
('2', '2', '2024-03-25', '1');

-- 6
SELECT 
    cliente.nome AS cliente,
    produto.nome AS produto,
    produto.categoria AS categoria
FROM
    pedido
        INNER JOIN
    cliente ON pedido.id_cliente = cliente.id
        INNER JOIN
    produto ON pedido.id_produto = produto.id
WHERE
    pedido.id_produto IN (SELECT 
            produto.id
        FROM
            produto
        WHERE
            produto.categoria = 'Moveis');






