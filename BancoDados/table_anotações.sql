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

select distinct(autor) from livro;

select sum(preco),avg(preco),max(preco),min(preco)  from livro;

select count(id) from livro;

select * from livro
order by titulo, preco asc;

select * from livro
order by titulo desc;

