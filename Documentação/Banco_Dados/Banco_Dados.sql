CREATE TABLE cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    cpf VARCHAR(11) NOT NULL UNIQUE,
    telefone VARCHAR(11) NOT NULL UNIQUE
);

CREATE TABLE pedido (
    id INT PRIMARY KEY AUTO_INCREMENT,
    dataDoPedido DATETIME NOT NULL,
    valor DECIMAL (10,2) NOT NULL,
    id_cliente INT NOT NULL,
    FOREIGN KEY (id_cliente)
        REFERENCES cliente (id)
);

CREATE TABLE produto (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    valor DECIMAL(10,2) NOT NULL,
    estoque INT NOT NULL
);

CREATE TABLE servico (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    valor DECIMAL(10,2) NOT NULL
);

CREATE TABLE PedidoProduto (
    id_produto INT NOT NULL,
    id_pedido INT NOT NULL,
    quantidade INT NOT NULL,
    PRIMARY KEY (id_produto , id_pedido),
    FOREIGN KEY (id_produto)
        REFERENCES produto (id),
	FOREIGN KEY (id_pedido)
        REFERENCES pedido (id)
);

CREATE TABLE PedidoServico (
    id_servico INT NOT NULL,
    id_pedido INT NOT NULL,
    PRIMARY KEY (id_servico , id_pedido),
    FOREIGN KEY (id_servico)
        REFERENCES servico (id),
    FOREIGN KEY (id_pedido)
        REFERENCES pedido (id)
);
