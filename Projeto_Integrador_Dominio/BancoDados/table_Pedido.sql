CREATE TABLE pedido (
    id INT PRIMARY KEY AUTO_INCREMENT,
    dataDoPedido DATETIME NOT NULL,
    valor DECIMAL (10,2) NOT NULL,
    estado BIT DEFAULT 0,
    quantidade INT NOT NULL,
    id_cliente INT NOT NULL,
    FOREIGN KEY (id_cliente)
        REFERENCES cliente (id)
);

DROP TABLE pedido;

SELECT c * id_cliente FROM cliente c INNER JOIN cliente ON pedido.id_cliente = cliente.id WHERE id = @id;

UPDATE pedido SET id_cliente = @id_cliente, dataDoPedido = @dataDoPedido, telefone = @telefone, cpf = @cpf  WHERE id = @id;

c