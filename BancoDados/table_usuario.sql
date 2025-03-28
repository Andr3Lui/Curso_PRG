CREATE TABLE IF NOT EXISTS usuario (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(16) NOT NULL
);

SELECT 
    *
FROM
    usuario;

INSERT INTO usuario (nome, email, senha)
 VALUES ('André Luiz', 'andreluiz@email.com', 'Alps!1234');
 
 INSERT INTO usuario (nome, email, senha)
 VALUES 
 ('Neymar Jr.', 'njr@email.com', 'Brun4@'),
 ('Maria Madalena','MariaMad@email.com','MariMar1!'),
 ('Pablo Vitar','pablito@email.com','p.vittar3#');
 
 