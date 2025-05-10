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
 
 INSERT INTO servico (nome, valor) VALUES("Corte", "15.00"), ("Sobrancelha", "10.00"), ("Hidratação", "20.00");
 
 INSERT INTO PedidoServico (id_servico, id_pedido) VALUES (@id_servico, @id_pedido);