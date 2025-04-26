CREATE TABLE PedidoProduto (
    id_produto INT NOT NULL,
    id_pedido INT NOT NULL,
    PRIMARY KEY (id_produto , id_pedido),
    FOREIGN KEY (id_produto)
        REFERENCES produto (id),
	FOREIGN KEY (id_pedido)
        REFERENCES pedido (id)
);