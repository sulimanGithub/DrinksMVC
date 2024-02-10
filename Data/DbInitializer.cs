using DrinksMVC.Models;

namespace DrinksMVC.Data
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();
                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(Categories.Select(c => c.Value));
                }

                if (!context.Drinks.Any())
                {
                    context.AddRange
                    (
                        new Drink
                        {
                            Name = "Beer",
                            Price = 7.95M,
                            ShortDescription = "The most widely consumed alcohol",
                            LongDescription = "Beer is the world's oldest[1][2][3] and most widely consumed[4] alcoholic drink; it is the third most popular drink overall, after water and tea.[5] The production of beer is called brewing, which involves the fermentation of starches, mainly derived from cereal grains—most commonly malted barley, although wheat, maize (corn), and rice are widely used.[6] Most beer is flavoured with hops, which add bitterness and act as a natural preservative, though other flavourings such as herbs or fruit may occasionally be included. The fermentation process causes a natural carbonation effect, although this is often removed during processing, and replaced with forced carbonation.[7] Some of humanity's earliest known writings refer to the production and distribution of beer: the Code of Hammurabi included laws regulating beer and beer parlours.",
                            Category = Categories["Alcoholic"],
                            ImageUrl = "https://th.bing.com/th/id/OIP.3mtGxc1k_LLcDwilcMuDaAHaEo?rs=1&pid=ImgDetMain",
                            InStock = true,
                            IsPreferredDrink = true,
                            ImageThumbnailUrl = "https://th.bing.com/th/id/OIP.3mtGxc1k_LLcDwilcMuDaAHaEo?rs=1&pid=ImgDetMain"
                        },
                        new Drink
                        {
                            Name = "Rum & Coke",
                            Price = 12.95M,
                            ShortDescription = "Cocktail made of cola, lime and rum.",
                            LongDescription = "The world's second most popular drink was born in a collision between the United States and Spain. It happened during the Spanish-American War at the turn of the century when Teddy Roosevelt, the Rough Riders, and Americans in large numbers arrived in Cuba. One afternoon, a group of off-duty soldiers from the U.S. Signal Corps were gathered in a bar in Old Havana. Fausto Rodriguez, a young messenger, later recalled that Captain Russell came in and ordered Bacardi (Gold) rum and Coca-Cola on ice with a wedge of lime. The captain drank the concoction with such pleasure that it sparked the interest of the soldiers around him. They had the bartender prepare a round of the captain's drink for them. The Bacardi rum and Coke was an instant hit. As it does to this day, the drink united the crowd in a spirit of fun and good fellowship. When they ordered another round, one soldier suggested that they toast ¡Por Cuba Libre! in celebration of the newly freed Cuba.",
                            Category = Categories["Alcoholic"],
                            ImageUrl = "https://th.bing.com/th/id/R.db0b83420d125ea509c062be9cf87a15?rik=BZlwoUSGgUgD4A&pid=ImgRaw&r=0",
                            InStock = true,
                            IsPreferredDrink = false,
                            ImageThumbnailUrl = "https://th.bing.com/th/id/OIP.t3HbYGUqHphbkWKTHo99ogHaFj?w=1024&h=768&rs=1&pid=ImgDetMain"
                        },
                        new Drink
                        {
                            Name = "Tequila ",
                            Price = 12.95M,
                            ShortDescription = "Beverage made from the blue agave plant.",
                            LongDescription = "Tequila (Spanish About this sound [teˈkila] (help·info)) is a regionally specific name for a distilled beverage made from the blue agave plant, primarily in the area surrounding the city of Tequila, 65 km (40 mi) northwest of Guadalajara, and in the highlands (Los Altos) of the central western Mexican state of Jalisco. Although tequila is similar to mezcal, modern tequila differs somewhat in the method of its production, in the use of only blue agave plants, as well as in its regional specificity. Tequila is commonly served neat in Mexico and as a shot with salt and lime across the rest of the world.The red volcanic soil in the surrounding region is particularly well suited to the growing of the blue agave, and more than 300 million of the plants are harvested there each year.[1] Agave tequila grows differently depending on the region. Blue agaves grown in the highlands Los Altos region are larger in size and sweeter in aroma and taste. Agaves harvested in the lowlands, on the other hand, have a more herbaceous fragrance and flavor.",
                            Category = Categories["Alcoholic"],
                            ImageUrl = "https://th.bing.com/th/id/OIP.qwijhmTgNe3PrQyiilJ4nQHaE8?rs=1&pid=ImgDetMain",
                            InStock = true,
                            IsPreferredDrink = false,
                            ImageThumbnailUrl = "https://th.bing.com/th/id/OIP.q1DGvQxpOiWiUZo1jhdajwHaFj?rs=1&pid=ImgDetMain"
                        },
                        new Drink
                        {
                            Name = "Wine ",
                            Price = 16.75M,
                            ShortDescription = "A very elegant alcoholic drink",
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Category = Categories["Alcoholic"],
                            ImageUrl = "https://th.bing.com/th/id/OIP.ASafRK0N670zeEu0iXRK2gHaE3?rs=1&pid=ImgDetMain",
                            InStock = true,
                            IsPreferredDrink = false,
                            ImageThumbnailUrl = "https://th.bing.com/th/id/OIP.7KbHuGr1aPB5Tw12cRxiFwHaEo?rs=1&pid=ImgDetMain"
                        },
                        new Drink
                        {
                            Name = "Margarita",
                            Price = 17.95M,
                            ShortDescription = "A cocktail with sec, tequila and lime",
                            Category = Categories["Alcoholic"],
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            ImageUrl = "https://th.bing.com/th/id/OIP.qtkscBnEoYK-JN4wmCKTGAHaLH?rs=1&pid=ImgDetMain",
                            InStock = true,
                            IsPreferredDrink = false,
                            ImageThumbnailUrl = "https://th.bing.com/th/id/OIP.l6UDwW2fxAPV1koJfLeycQHaLF?pid=ImgDet&w=184&h=276&c=7"
                        },
                        new Drink
                        {
                            Name = "Whiskey with Ice",
                            Price = 15.95M,
                            ShortDescription = "The best way to taste whiskey",
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Category = Categories["Alcoholic"],
                            ImageUrl = "https://th.bing.com/th/id/R.47b099aaab13b5a93a8578086a637ce7?rik=wgolnj%2fO9PpJ%2bw&riu=http%3a%2f%2fda8oyxvttwp2m.cloudfront.net%2fwp-content%2fuploads%2f2016%2f05%2f1692364.jpg&ehk=N9fbZuIq%2fTwJ%2f8bZPwgQrzIBrOggem6tb0QwF4lp5Y0%3d&risl=&pid=ImgRaw&r=0",
                            InStock = false,
                            IsPreferredDrink = false,
                            ImageThumbnailUrl = "https://th.bing.com/th/id/OIP.WV_xHvVjlEeJOk04DbSgOwAAAA?pid=ImgDet&w=184&h=154&c=7"
                        },
                        new Drink
                        {
                            Name = "Jägermeister",
                            Price = 15.95M,
                            ShortDescription = "A German digestif made with 56 herbs",
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Category = Categories["Alcoholic"],
                            ImageUrl = "https://th.bing.com/th/id/R.e945129bdffbd90746f16e23e1eb3a04?rik=TAi72sjS9MY%2fqA&pid=ImgRaw&r=0",
                            InStock = false,
                            IsPreferredDrink = false,
                            ImageThumbnailUrl = "https://th.bing.com/th/id/R.e945129bdffbd90746f16e23e1eb3a04?rik=TAi72sjS9MY%2fqA&pid=ImgRaw&r=0"
                        },
                        new Drink
                        {
                            Name = "Champagne",
                            Price = 15.95M,
                            ShortDescription = "That is how sparkling wine can be called",
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Category = Categories["Alcoholic"],
                            ImageUrl = "https://th.bing.com/th/id/OIP.oH6eS3dyyC3QjGtX1Gb9ZQHaE8?rs=1&pid=ImgDetMain",
                            InStock = false,
                            IsPreferredDrink = false,
                            ImageThumbnailUrl = "https://th.bing.com/th/id/OIP.yg4Z2DhXQGm0-1UsfzZ1TgHaE7?pid=ImgDet&w=184&h=122&c=7"
                        },
                        new Drink
                        {
                            Name = "Piña colada ",
                            Price = 15.95M,
                            ShortDescription = "A sweet cocktail made with rum.",
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Category = Categories["Alcoholic"],
                            ImageUrl = "https://th.bing.com/th/id/R.7e2537fb5e8406a29eaa44435f3be0a0?rik=klluo72eaY7Ntg&pid=ImgRaw&r=0",
                            InStock = false,
                            IsPreferredDrink = false,
                            ImageThumbnailUrl = "https://th.bing.com/th/id/R.7e2537fb5e8406a29eaa44435f3be0a0?rik=klluo72eaY7Ntg&pid=ImgRaw&r=0"
                        },
                        new Drink
                        {
                            Name = "White Russian",
                            Price = 15.95M,
                            ShortDescription = "A cocktail made with vodka ",
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Category = Categories["Alcoholic"],
                            ImageUrl = "https://th.bing.com/th/id/OIP.4NgcMclPacnZpvW93RuCEQHaHa?rs=1&pid=ImgDetMain",
                            InStock = false,
                            IsPreferredDrink = false,
                            ImageThumbnailUrl = "https://th.bing.com/th/id/OIP.4NgcMclPacnZpvW93RuCEQHaHa?rs=1&pid=ImgDetMain"
                        },
                        new Drink
                        {
                            Name = "Long Island Iced Tea",
                            Price = 15.95M,
                            ShortDescription = "Aa mixed drink made with tequila.",
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Category = Categories["Alcoholic"],
                            ImageUrl = "https://th.bing.com/th/id/R.16d60555fae52aff91dd8365642e4b45?rik=ift4ycSzpJzhhA&pid=ImgRaw&r=0",
                            InStock = false,
                            IsPreferredDrink = false,
                            ImageThumbnailUrl = "https://th.bing.com/th/id/OIP.wWXDOq63I2FCtcQj_Kld6gHaLH?w=680&h=1020&rs=1&pid=ImgDetMain"
                        },
                        new Drink
                        {
                            Name = "Vodka",
                            Price = 15.95M,
                            ShortDescription = "A distilled beverage with water and ethanol.",
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Category = Categories["Alcoholic"],
                            ImageUrl = "https://th.bing.com/th/id/R.d6e637f8035cc16f64b70df26dcc812e?rik=nZHLUissW3zRaQ&pid=ImgRaw&r=0",
                            InStock = false,
                            IsPreferredDrink = false,
                            ImageThumbnailUrl = "https://th.bing.com/th/id/OIP.GErtv8o7nWD8Yogh7OvDPwHaLG?pid=ImgDet&w=184&h=276&c=7"
                        },
                        new Drink
                        {
                            Name = "Gin and tonic",
                            Price = 15.95M,
                            ShortDescription = "Made with gin and tonic water poured over ice.",
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Category = Categories["Alcoholic"],
                            ImageUrl = "https://th.bing.com/th/id/OIP.CxD387sDY4OwVdnDIQd_DwHaE8?rs=1&pid=ImgDetMain",
                            InStock = false,
                            IsPreferredDrink = false,
                            ImageThumbnailUrl = "https://th.bing.com/th/id/OIP.CxD387sDY4OwVdnDIQd_DwHaE8?rs=1&pid=ImgDetMain"
                        },
                        new Drink
                        {
                            Name = "Cosmopolitan",
                            Price = 15.95M,
                            ShortDescription = "Made with vodka, triple sec, cranberry juice.",
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Category = Categories["Alcoholic"],
                            ImageUrl = "https://th.bing.com/th/id/R.dcd8b0fe9fa6a918a67156e9486d1ad9?rik=jxy%2b3wCZjRoyBQ&pid=ImgRaw&r=0",
                            InStock = false,
                            IsPreferredDrink = false,
                            ImageThumbnailUrl = "https://th.bing.com/th/id/R.dcd8b0fe9fa6a918a67156e9486d1ad9?rik=jxy%2b3wCZjRoyBQ&pid=ImgRaw&r=0"
                        },
                        new Drink
                        {
                            Name = "Tea ",
                            Price = 12.95M,
                            ShortDescription = "Made by leaves of the tea plant in hot water.",
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Category = Categories["Non-alcoholic"],
                            ImageUrl = "https://th.bing.com/th/id/OIP.QFZj1pyMT7MML0mad43xQwHaEo?rs=1&pid=ImgDetMain",
                            InStock = true,
                            IsPreferredDrink = true,
                            ImageThumbnailUrl = "https://th.bing.com/th/id/OIP.tnOkvzZTRgAo-mGUs7JsGQHaE8?pid=ImgDet&w=184&h=122&c=7"
                        },
                        new Drink
                        {
                            Name = "Water ",
                            Price = 12.95M,
                            ShortDescription = " It makes up more than half of your body weight ",
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Category = Categories["Non-alcoholic"],
                            ImageUrl = "https://th.bing.com/th/id/OIP.-raAVneDDjun8o-YrIcttgHaJ2?rs=1&pid=ImgDetMain",
                            InStock = true,
                            IsPreferredDrink = false,
                            ImageThumbnailUrl = "https://th.bing.com/th/id/OIP.eieeQTnrnQ7wgDtUjN44wQAAAA?pid=ImgDet&w=184&h=276&c=7"
                        },
                        new Drink
                        {
                            Name = "Coffee ",
                            Price = 12.95M,
                            ShortDescription = " A beverage prepared from coffee beans",
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Category = Categories["Non-alcoholic"],
                            ImageUrl = "https://th.bing.com/th/id/OIP.Ex4HNe0slI8a_oF4iue0YwHaEo?rs=1&pid=ImgDetMain",
                            InStock = true,
                            IsPreferredDrink = true,
                            ImageThumbnailUrl = "https://th.bing.com/th/id/OIP.731dy08emdOSmne0XQVqzQHaHa?pid=ImgDet&w=184&h=184&c=7"
                        },
                        new Drink
                        {
                            Name = "Kvass",
                            Price = 12.95M,
                            ShortDescription = "A very refreshing Russian beverage",
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Category = Categories["Non-alcoholic"],
                            ImageUrl = "https://th.bing.com/th/id/OIP.y2XQww3k_ZIs9zRxHrL5nQHaE8?rs=1&pid=ImgDetMain",
                            InStock = true,
                            IsPreferredDrink = false,
                            ImageThumbnailUrl = "https://th.bing.com/th/id/OIP.a43QcESGHyjtAWM9Jy_y7QHaLG?pid=ImgDet&w=184&h=276&c=7"
                        },
                        new Drink
                        {
                            Name = "Juice ",
                            Price = 12.95M,
                            ShortDescription = "Naturally contained in fruit or vegetable tissue.",
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Category = Categories["Non-alcoholic"],
                            ImageUrl = "https://th.bing.com/th/id/R.931cef6c0be858d80bcbc98434bc9178?rik=2sEHRcyvFMCi8A&pid=ImgRaw&r=0",
                            InStock = true,
                            IsPreferredDrink = false,
                            ImageThumbnailUrl = "https://th.bing.com/th/id/OIP.pWZ_-d8jEGR0r9Zx5njRzAHaE8?pid=ImgDet&w=184&h=122&c=7"
                        }
                    );
                }

                context.SaveChanges();
            }
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Alcoholic", Description="All alcoholic drinks" },
                        new Category { CategoryName = "Non-alcoholic", Description="All non-alcoholic drinks" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
