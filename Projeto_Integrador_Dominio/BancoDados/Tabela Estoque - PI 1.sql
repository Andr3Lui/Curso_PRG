CREATE TABLE estoque (
    id INT PRIMARY KEY AUTO_INCREMENT,
    quantidade INT NOT NULL,
    id_produto INT NOT NULL,
    FOREIGN KEY (id_produto)
        REFERENCES produto (id)
);
