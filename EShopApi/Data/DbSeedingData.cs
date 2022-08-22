using Microsoft.AspNetCore.Identity;

namespace EShopApi.Data
{
    public static class DbSeedingData
    {
        public static async Task Initialize(EShopContext context, UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new User
                {
                    UserName = "thinh",
                    Email = "thinh@test.com"
                };

                await userManager.CreateAsync(user, "Thinhmember123@");
                await userManager.AddToRoleAsync(user, "Member");

                var admin = new User
                {
                    UserName = "admin",
                    Email = "admin@test.com"
                };

                await userManager.CreateAsync(admin, "Thinhadmin123@");
                await userManager.AddToRolesAsync(admin, new[] { "Member", "Admin" });
            }

            if (context.Products.Any()) return;
            if (context.Brands.Any()) return;

            var brands = new List<Brand>
            {
                new Brand
                {
                    Name="Uniqlo"
                },
                new Brand
                {
                    Name = "Nike"
                },
                new Brand
                {
                    Name = "HM"
                },
                new Brand
                {
                    Name = "adidas"
                },
            };
            var products = new List<Product>
            {
                new Product
                {
                    Name = "Áo Thun Cổ Tròn Ngắn Tay",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl = "https://image.uniqlo.com/UQ/ST3/AsianCommon/imagesgoods/431599/item/goods_69_431599.jpg?width=1600&impolicy=quality_75",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Áo Thun Cổ Tròn Ngắn Tay",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 10000,
                    PictureUrl = "https://image.uniqlo.com/UQ/ST3/AsianCommon/imagesgoods/422992/item/goods_38_422992.jpg?width=1008&impolicy=quality_75",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Áo Thun Cổ Tròn Ngắn Tay",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 30000,
                    PictureUrl = "",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Áo Thun Cổ Tròn Ngắn Tay",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 40000,
                    PictureUrl = "https://image.uniqlo.com/UQ/ST3/vn/imagesgoods/427917/item/vngoods_56_427917.jpg?width=1008&impolicy=quality_75",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Áo Thun Cổ Tròn Ngắn Tay",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 50000,
                    PictureUrl = "https://image.uniqlo.com/UQ/ST3/vn/imagesgoods/425974/item/vngoods_69_425974.jpg?width=1008&impolicy=quality_75",
                    QuantityInStock = 100
                },
                 new Product
                {
                    Name = "Áo Thun Cổ Tròn Ngắn Tay",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 60000,
                    PictureUrl = "https://image.uniqlo.com/UQ/ST3/AsianCommon/imagesgoods/425974001/item/goods_37_425974001.jpg?width=1008&impolicy=quality_75",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Áo Thun Cổ Tròn Ngắn Tay",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 70000,
                    PictureUrl = "https://image.uniqlo.com/UQ/ST3/AsianCommon/imagesgoods/442821/item/goods_56_442821.jpg?width=1008&impolicy=quality_75",
                    QuantityInStock = 100
                },
                   new Product
                {
                    Name = "Áo Thun Cổ Tròn Ngắn Tay",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 70000,
                    PictureUrl = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/e6af4a93-5f8c-431b-a1de-04b11744e6ee/sportswear-essentials-t-shirt-K9vnhV.png",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Áo Thun Cổ Tròn Ngắn Tay",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 80000,
                    PictureUrl = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/61314f5e-95bd-41a4-adc5-085cf45b1e82/pro-dri-fit-shorts-8jxLsr.png",
                    QuantityInStock = 100
                },
               new Product
                {
                    Name = "Áo Thun Cổ Tròn Ngắn Tay",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 10000,
                    PictureUrl = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/5a65c165-ee14-49a8-ae60-b4703b182e93/jordan-sport-dna-statement-top-FN3RjF.png",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Áo Thun Cổ Tròn Ngắn Tay",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 15000,
                    PictureUrl = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/d9bb3f55-801e-4cb0-963e-9ea2c01dce46/sportswear-max90-t-shirt-tdVGGv.pnghttps://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/e257dd01-5ae2-4e51-aa8c-010eca09adc6/esc-lightweight-jacket-ZgMQFp.png",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Áo Thun Cổ Tròn Ngắn Tay",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 70000,
                    PictureUrl = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/72628cce-fa35-4c81-b494-8b932b93cbbb/dri-fit-golf-shorts-QNrCtG.png",
                    QuantityInStock = 100
                },


            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }
            foreach (var brand in brands)
            {
                context.Brands.Add(brand);
            }

            context.SaveChanges();
        }
    }
}