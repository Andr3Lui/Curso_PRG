/*//TABELA EMPREGADOS
*/
CREATE TABLE IF NOT EXISTS empregado (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    idade INT(3) NOT NULL,
    id_departamento INT NOT NULL,
    salario DECIMAL NOT NULL,
    FOREIGN KEY (id_departamento)
        REFERENCES departamento (id)
);
INSERT INTO empregado
(
 nome, idade, id_departamento, salario
)
VALUES
('João', '30', '1', '50000'),
('Sarah', '28','2','60000'),
('Miguel','35','3','55000'),
('Ana','27','2','62000');
SELECT * FROM empregado;


/*//TABELA DEPARTAMENTO
*/
CREATE TABLE IF NOT EXISTS departamento
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR (50) NOT NULL UNIQUE
);
INSERT INTO departamento
(
 nome
)
VALUE
('RH'),
('TI'),
('Vendas'),
('Marketing'),
('Segurança');

SELECT * FROM departamento;

drop table empregado;
drop table departamento;



/*//EXERCICIO 1
*/
-- visão geral da tabela de empregados
SELECT 
    *
FROM
    empregado;
    
-- visualizar apenas os empregados do departamneto de TI
SELECT 
    *
FROM
    empregado
WHERE
    departamento = 'TI';
    
-- empregados que ganham mais de 55000
    SELECT 
    empregado.nome, empregado.salario
FROM
    empregado
WHERE
    salario > '55000';
    
-- lisat de empregados em ordem crescente
SELECT 
    *
FROM
    empregado
ORDER BY idade ASC;

/*//EXERCICIO 2
*/
-- selecionar empregados com idade entre 28 e 35 anos.,
    SELECT 
    *
FROM
    empregado
WHERE
    idade > '27' AND idade < '36';

-- NOMES INICIADOS EM 'M'
SELECT 
    *
FROM
    empregado
WHERE
    nome LIKE 'M%';

-- EMPREGADOS QUE NÃO ESTÃO NO DEPARTAMENTO 'RH' 
SELECT 
    *
FROM
    empregado
WHERE
    departamento != 'RH';

/*//EXERCICIO 3

*/
-- SELECIONE O NUMERO DE EMPREGADOS POR DEPARTAMENTO
SELECT COUNT(id) FROM empregado WHERE departamento = 'RH';

SELECT COUNT(id) FROM empregado WHERE departamento = 'TI';

SELECT COUNT(id) FROM empregado WHERE departamento = 'VENDAS';

-- MÉDIA SALARIAL
SELECT AVG(salario) FROM empregado;

-- MÉDIA SALARIAL TI
SELECT AVG(salario) FROM empregado WHERE departamento = 'TI';

-- TOTAL SALARIOS VENDAS
SELECT SUM(salario) FROM empregado WHERE departamento = 'Vendas';

/*//EXERCICIO 4
*/
-- EMPREGADOS COM SEUS RESPECTIVOS DEPARTAMENTOS
SELECT 
    empregado.id,
    empregado.nome,
    empregado.salario,
    departamento.nome AS departamento
FROM
    empregado
        INNER JOIN
    departamento ON empregado.id_departamento = departamento.id;

-- TODOS OS DEPARTAMENTOS, MESMO QUE SEM EMPREGADOS
SELECT 
    empregado.id,
    empregado.nome,
    empregado.salario,
    departamento.nome AS departamento
FROM
    departamento
        LEFT JOIN
    empregado ON departamento.id = empregado.id_departamento;
    
/*//EXERCICIO 5

*/
--
SELECT 
    empregado.id,
    empregado.nome,
    empregado.salario,
    departamento.nome AS departamento
FROM
    empregado
INNER JOIN 
departamento ON empregado.id_departamento = departamento.id
         
WHERE
    salario > (SELECT 
            AVG(salario)
        FROM
            empregado);

--
 
SELECT 
   empregado.id, empregado.nome, departamento.nome AS departamento
FROM
    empregado
INNER JOIN 
 departamento on empregado.id_departamento = departamento.id

WHERE
    empregado.id_departamento = (SELECT 
            empregado.id_departamento
        FROM
            empregado
        WHERE
            empregado.nome = 'Sarah');


/*//EXERCICIO 6
*/

INSERT INTO empregado
(
nome, idade, id_departamento, salario
)
values
('Tomás','32','3','58000');

SELECT empregado.nome, (salario * 0.05) + salario AS TI
FROM empregado
WHERE id_departamento = 2;

DELETE FROM empregado
WHERE idade > 40;

