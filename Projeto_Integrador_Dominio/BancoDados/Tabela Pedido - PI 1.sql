CREATE TABLE pedido (
	id INT PRIMARY KEY AUTO_INCREMENT,
	dataDoPedido VARCHAR(8) NOT NULL,
    estado BIT DEFAULT 0,
    id_cliente INT NOT NULL,
	FOREIGN KEY (id_cliente)
		REFERENCES cliente (id)
);
