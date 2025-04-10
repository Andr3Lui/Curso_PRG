CREATE TABLE IF NOT EXISTS endereco (
    id INT PRIMARY KEY AUTO_INCREMENT,
    logradouro VARCHAR(100) NOT NULL,
    numero VARCHAR(4) NOT NULL,
    complemento VARCHAR(50) NULL,
    bairro VARCHAR(50) NOT NULL,
    municipio VARCHAR(50) NOT NULL,
    estado VARCHAR(50) NOT NULL,
    cep VARCHAR(8) NOT NULL
);

INSERT INTO endereco 
(
logradouro, numero, complemento, bairro, municipio, estado, cep
)
VALUES
('Rua do Jacaraí', '974', null, 'Fernando de Aquino', 'Beruri', 'AM', '08556920'),
('Av. Brasil', '78', 'Ao Lado da Igreja da Penha', 'Penha', 'Madureira', 'RJ', '09563451'),
('Rua Medeiros', '14', 'Bloco C', 'Jd. Macedonia', 'Itapecerica da Serra', 'SP', '05823659');

SELECT 
    *
FROM
    endereco;