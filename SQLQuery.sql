SELECT product.Name, category.Name FROM 
Product product LEFT JOIN Product_Categorys Product_Category ON product.Id = Product_Category.ProductId
LEFT JOIN Category category ON category.Id = Product_Category.CategoryId