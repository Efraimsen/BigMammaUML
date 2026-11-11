using BigMammaV3.Configurations;
using BigMammaV3.Interfaces;
using BigMammaV3.Models;
using BigMammaV3.Repositories;
using BigMammaV3.Services;
using BigMammaV3.UserInterface;

IJsonService jsonService = new JsonService();
ConfigurationsService configuraationsService = new ConfigurationsService(jsonService, Path.Combine(AppContext.BaseDirectory, "appsettings.json"));
AppSettings settings = configuraationsService.Load();

IRepository<Item> itemRepository = new ItemRepository(jsonService, settings);
IRepository<Member> memberRepository = new MemberRepository(jsonService, settings);
IRepository<Order> orderRepository = new OrderRepository(jsonService, settings);

Console.WriteLine("");
Input input = new Input();



Console.WriteLine(itemRepository.ToString());

Member newMember = new Member();

Order myOrder = new Order(newMember);

Console.WriteLine(myOrder);