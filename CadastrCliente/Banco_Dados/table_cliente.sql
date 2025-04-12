CREATE TABLE IF NOT EXISTS cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    data_nascimento DATETIME NOT NULL,
    nome_social VARCHAR(100) NULL,
    telefone VARCHAR(11) NOT NULL UNIQUE,
    email VARCHAR(50) NOT NULL UNIQUE,
    estrangeiro BIT NULL,
    genero INT NOT NULL,
    etnia INT NOT NULL,
    tipo INT NOT NULL,
    id_endereco INT NOT NULL,
    FOREIGN KEY (id_endereco)
        REFERENCES endereco (id)
);

INSERT INTO cliente
(
nome, data_nascimento, nome_social, telefone, email, id_endereco
) 
VALUES
('Barbara Reali', '03072005', null, '11944597865', 'B4rbar!@email.com', '1'),
('Pedro Nascimento', '26041998', null, '11978842341', 'P&dr0Nasc@email.com', '2'),
('Sukuna Nakima', '30012000', 'Paulo Silva', '11945678512', 'Sukuna77#@email.com', '3');

SELECT 
    *
FROM
    cliente c
join
endereco e on c.id_endereco = e.id

group by nome