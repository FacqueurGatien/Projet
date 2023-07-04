--SELECT * FROM vegetables;
--SELECT * FROM Sales;

-- 1
SELECT vegid,"name",variety,primarycolor,lifetime,fresh FROM vegetables ORDER BY "name";

-- 2 
SELECT DISTINCT V."name",S.saleunitprice, V.variety,COUNT(BV.saleid)AS nb_ventes_variete,SUM(BV.saleweight) AS poids_total_vendu_variete
FROM vegetables AS V
NATURAL LEFT JOIN sales AS S
LEFT JOIN vegetables AS B ON B.variety = V.variety
LEFT JOIN sales AS BV ON B.vegid = bv.vegid
GROUP BY V.vegid , S.saleID;

-- 3 
SELECT vegid,"name",variety,primarycolor,lifetime,fresh FROM vegetables
WHERE ("name" LIKE '%on' AND primarycolor NOT LIKE 'green') OR ("name" NOT LIKE '%on%' AND primarycolor LIKE 'green');

-- 4
SELECT DISTINCT ON (V.vegId ) V.vegId, V."name",S.saleunitprice, V.variety, (S.saleunitprice * SUM(S.saleweight))AS tot_price_sell, AVG(S.saleweight) AS avg_weight_sale
, vv.saleweight AS best_weight_sale , (MAX(VV.saleweight) * s.saleunitprice) AS best_sell_price
FROM vegetables AS v
NATURAL JOIN sales AS S
INNER JOIN sales AS VV ON VV.vegid = v.vegid
GROUP BY V.vegId,VV.saleweight,S.saleunitprice
ORDER BY V.vegID ASC, VV.saleweight DESC;
