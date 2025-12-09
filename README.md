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
