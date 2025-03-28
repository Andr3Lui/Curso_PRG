CREATE TABLE IF NOT EXISTS produto (
    id INT PRIMARY KEY AUTO_INCREMENT,
    roupas VARCHAR(50) NOT NULL,
    preço INT(10) NOT NULL,
    estado VARCHAR(50) NOT NULL,
    promoção VARCHAR(50) NOT NULL
);

SELECT 
    *
FROM
    produto;

INSERT INTO produto (roupas, preço, estado, promoção)

VALUES 
('Camiseta' ,'10' ,'Nova' ,'Promocional' ),
('Calça Cargo' ,'25' ,'Nova' ,'Normal' ),
('Chapéu' ,'5' ,'Nova' ,'Normal' ),
('Boné' ,'5' ,'Nova' ,'Promocional' ),
('Sapato' ,'14' ,'Nova' ,'Normal' ),
('Tenis' ,'12' ,'Nova' ,'Normal' ),
('BabyLook' ,'8' ,'Nova' ,'Normal' ),
('Blusa Moletom' ,'20' ,'Nova' ,'Promocional' ),
('Jaqueta Jeans' ,'35' ,'Nova' ,'Normal' ),
('Jaqueta Couro' ,'40' ,'Nova' ,'Normal' ),
('Camisa' ,'15' ,'Nova' ,'Normal' ),
('Regata' ,'10' ,'Nova' ,'Normal' ),
('Gravata' ,'4' ,'Nova' ,'Normal' ),
('Meia' ,'2' ,'Nova' ,'Promocional' ),
('Cueca' ,'5' ,'Nova' ,'Normal' ),
('Calcinha' ,'5' ,'Nova' ,'Promocional');

SELECT 
    *
FROM
    produto
WHERE
    id = 1;
    
    SELECT 
    *
FROM
    produto
WHERE
    roupas = 'Jaqueta Jeans';
    
    SELECT 
    *
FROM
    produto
WHERE
    preço = 10;
    
    SELECT 
    *
FROM
    produto
WHERE
    promoção = 'Promocional';