CREATE TABLE PedidoServico (
    id_servico INT NOT NULL,
    id_pedido INT NOT NULL,
    PRIMARY KEY (id_servico , id_pedido),
    FOREIGN KEY (id_servico)
        REFERENCES servico (id),
    FOREIGN KEY (id_pedido)
        REFERENCES pedido (id)
);

 DROP TABLE PedidoServico;
 
 SELECT * FROM servico;
 
 INSERT INTO servico (nome, valor) 
 VALUES
 ("Tintura", 18.00),
 ("Escova", 15.00),
 ("Progressiva", 100.00),
 ("Luzes", 30.00),
 ("Reconstrução", 25.00),
 ("Nutrição", 22.00);
 
 INSERT INTO PedidoServico (id_servico, id_pedido) VALUES (@id_servico, @id_pedido);