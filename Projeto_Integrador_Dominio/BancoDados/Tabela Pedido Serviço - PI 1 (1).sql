CREATE TABLE PedidoServico (
    id_servico INT NOT NULL,
    id_pedido INT NOT NULL,
    PRIMARY KEY (id_servico , id_pedido),
    FOREIGN KEY (id_servico)
        REFERENCES servico (id),
    FOREIGN KEY (id_pedido)
        REFERENCES pedido (id)
);
