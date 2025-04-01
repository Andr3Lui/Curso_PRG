/*
//
//FORMAS DIFERENTES DE VERIFICAR UMA DATA.
//
SELECT 
    *
FROM
    livro
WHERE data_publicacao > '1989-12-31'
AND data_publicacao < '2000-01-01';

SELECT 
    *
FROM
    livro
WHERE data_publicacao between '1989-12-31' AND '2000-01-01';

SELECT 
    *
FROM
    livro
WHERE year(data_publicacao) between '1990' AND '1999';

//
//COMO PROCURA POR UM DADO SEM REPETILO QUANDO APARECE MAIS DE UMA VEZ.
//
select distinct(autor) from livro;

//
//METODOS PARA VERIFICAR VALORES OU CONTAS ARITMÉTICAS.
//
select sum(preco),avg(preco),max(preco),min(preco)  from livro;

select count(id) from livro;

//
//ORDENAR UMA COLUNA POR ORDEM CRESCENTE E DESCRECENTE.
//
select * from livro
order by titulo, preco asc;

select * from livro
order by titulo desc;

//
//PEDIR UMA INFORMAÇÃO MODIFICADA.
//
SELECT DISTINCT
    lower(autor)
FROM
    livro; 
    
//
//FORMAS DIFERNETES DE ARMONIZAR UMA BUSCA EM TABELAS 
//
//
//PERFORMATICA
//
SELECT 
    livro.id,
    livro.titulo,
    livro.data_publicacao,
    livro.numero_paginas,
    livro.preco,
    livro.isbn,
    genero.nome AS genero,
    autor.nome AS autor,
    editora.nome AS editora
    FROM 
    livro
    INNER JOIN genero ON livro.id_genero = genero.id
    INNER JOIN autor ON livro.id_autor = autor.id
    INNER JOIN editora ON livro.id_editora = editora.id;
//
//CUSTOSA
//
SELECT 
    livro.id,
    livro.titulo,
    livro.data_publicacao,
    livro.numero_paginas,
    livro.preco,
    livro.isbn,
    genero.nome AS genero,
    autor.nome AS autor,
    editora.nome AS editora
    
FROM
	livro,
    genero,
    autor,
    editora
WHERE 
	livro.id_genero = genero.id
    and
    livro.id_autor = autor.id
    and
    livro.id_editora = editora.id

*/


