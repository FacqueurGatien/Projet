--SELECT * FROM vegetables;
--SELECT * FROM Sales;

-- 1
SELECT id,"name",variety,primarycolor,lifetime,fresh FROM vegetables ORDER BY "name";

-- 2 
SELECT DISTINCT V."name",S.saleunitprice, V.variety,COUNT(BV.saleid)AS nb_ventes_variete,SUM(BV.saleweight) AS poids_total_vendu_variete
FROM vegetables AS V
NATURAL JOIN sales AS S
INNER JOIN vegetables AS B ON B.variety = V.variety
INNER JOIN sales AS BV ON b.id = bv.Id
GROUP BY V.Id , S.saleID;

-- 3 
SELECT id,"name",variety,primarycolor,lifetime,fresh FROM vegetables
WHERE ("name" LIKE '%on' AND primarycolor NOT LIKE 'green') OR ("name" NOT LIKE '%on%' AND primarycolor LIKE 'green');

-- 4
SELECT DISTINCT ON (V.Id ) V.Id, V."name",S.saleunitprice, V.variety, (S.saleunitprice * SUM(S.saleweight))AS tot_price_sell, AVG(S.saleweight) AS avg_weight_sale
, vv.saleweight AS best_weight_sale , (MAX(VV.saleweight) * s.saleunitprice) AS best_sell_price
FROM vegetables AS v
NATURAL JOIN sales AS S
INNER JOIN sales AS VV ON VV.id = v.id
GROUP BY V.Id,VV.saleweight,S.saleunitprice
ORDER BY V.ID ASC, VV.saleweight DESC;
