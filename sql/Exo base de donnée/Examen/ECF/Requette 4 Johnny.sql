SELECT 
	DISTINCT ON (V.vegid ) V.vegid
	, V."name"
	, COUNT (V."name") 
	, V.variety
	, (S.saleunitprice * SUM(S.saleweight))AS tot_price_sell
	, AVG(S.saleweight) AS avg_weight_sale
	, vv.saleweight AS best_weight_sale 
	, (MAX(VV.saleweight) * s.saleunitprice) AS best_sell_price
	,S.saleunitprice
FROM vegetables AS v
NATURAL JOIN sales AS S
INNER JOIN sales AS VV ON VV.vegid = v.vegid
GROUP BY V.vegid,VV.saleweight,S.saleunitprice
ORDER BY V.vegid ASC, VV.saleweight DESC;
/*
SELECT DISTINCT ON (V.vegid ) V.vegid, V."name",S.saleunitprice, V.variety, (S.saleunitprice * SUM(S.saleweight))AS tot_price_sell, AVG(S.saleweight) AS avg_weight_sale
, vv.saleweight AS best_weight_sale , (MAX(VV.saleweight) * s.saleunitprice) AS best_sell_price
FROM vegetables AS v
NATURAL JOIN sales AS S
INNER JOIN sales AS VV ON VV.vegid = v.vegid
GROUP BY V.vegid,VV.saleweight,S.saleunitprice
ORDER BY V.vegid ASC, VV.saleweight DESC;*/