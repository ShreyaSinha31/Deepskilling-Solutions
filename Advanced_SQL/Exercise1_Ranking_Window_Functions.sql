USE OnlineRetailStore;
GO

SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RowNum
FROM Products;


USE OnlineRetailStore;
GO

SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RankNo
FROM Products;


USE OnlineRetailStore;
GO

SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    DENSE_RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS DenseRankNo
FROM Products;


USE OnlineRetailStore;
GO

SELECT *
FROM
(
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER
        (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS RowNum
    FROM Products
) AS RankedProducts
WHERE RowNum <= 3;
