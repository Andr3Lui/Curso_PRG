CREATE TABLE pedido (
    id INT PRIMARY KEY AUTO_INCREMENT,
    dataDoPedido DATETIME NOT NULL,
    valor DECIMAL (10,2) NOT NULL,
    estado BIT DEFAULT 0,
    id_cliente INT NOT NULL,
    FOREIGN KEY (id_cliente)
        REFERENCES cliente (id)
);

INSERT INTO pedido (dataDoPedido, valor, estado, id_cliente) VALUES (@dataDoPedido, @valor, @estado, @id_cliente);

SELECT * FROM pedido WHERE dataDoPedido = @dataDoPedido AND valor = @valor AND estado = @estado AND id_cliente = @id_cliente;

DROP TABLE pedido;

SELECT produto.nome, produto.valor, produto.quantidade, servico.nome, servico.valor FROM pedidoproduto, pedidoservico INNER JOIN pedido ON pedido.id = pedidoproduto.id_produto INNER JOIN produto ON produto.id = pedidoproduto.id_produto INNER JOIN servico ON servico.id = pedidoservico.id_servico 
INNER JOIN cliente ON cliente.id = pedido.id_cliente  where pedido.id = @pedido;

UPDATE pedido SET id_cliente = @id_cliente, dataDoPedido = @dataDoPedido, telefone = @telefone, cpf = @cpf  WHERE id = @id;

SELECT id_cliente AS cliente, servico, produto, quantidade, dataDoPedido FROM pedido INNER JOIN cliente ON pedido.id_cliente = cliente.id;