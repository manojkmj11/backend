# Routing

### Why do we require routing?

> HTTP routing is needed because a single server needs to handle many different requests, and each request requires different logic. <br>
> e.g. with in a single api server we would have GET, POST, PUT, DELETE endpoints which contains different logic to handle different requirements.

---

### What is routing

> Directing the incoming HTTP request to it's appropriate controller that processes and generates a response. 

**Components**
- **HTTP Method:** GET, POST, PUT etc..
- **HTTP Route:** `/api/icecreams`
- **Controller:** This is where the specific code block resides which gets executed for a matching http method and route combination

**Types of routes**
1. **Static:** Fixed path/route (e.g. `/api/version`)
2. **Dynamic (path parameters):** Makes use of place holder variables to capture variables values within the url path. (e.g. `/api/icecreams/{id}`, to fetch specific ice cream's information, where `{id}` is the path parameter).
3. **Query:** Used for optional data like search, filtering, pagination etc.. (e.g. `api/icecreams?name=rich+chocolate`)
4. **Nested:** Used to create relationship between different resources, for better readability. (e.g. `api/icecreams/users/{id}`, fetch all user specific ice cream details where `{id}` is the path parameter representing the user id in this case.)
5. **Catch-all:** A route that matches all any URL not matched by previously defined routes, usually returns `404 rource not found` if the client requests a invalid endpoint/URL.