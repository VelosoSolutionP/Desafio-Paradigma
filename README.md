Resposta Tarefa1:
SELECT 
    d.Nome AS Departamento,
    p.Nome AS Pessoa,
    p.Salario
FROM Departamento d
INNER JOIN Pessoa p 
    ON p.DeptId = d.Id
INNER JOIN (
    SELECT DeptId, MAX(Salario) AS MaiorSalario
    FROM Pessoa
    GROUP BY DeptId
) AS m
    ON m.DeptId = p.DeptId
    AND m.MaiorSalario = p.Salario
ORDER BY d.Nome;

Realizado teste no da api que criei para atender aos requisitos do teste no postaman
Method Post: http://localhost:5151/api/arvore/construir
<img width="1515" height="869" alt="image" src="https://github.com/user-attachments/assets/9ba61f76-e58f-409a-8b28-975a4397eefa" />

<img width="1524" height="876" alt="image" src="https://github.com/user-attachments/assets/0dec219c-e4ef-49ef-b0c3-f9932579a0eb" />


