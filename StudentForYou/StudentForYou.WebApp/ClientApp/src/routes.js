
import Index from "./views/Index.jsx";
import Profile from "./views/examples/Profile.jsx";
import Maps from "./views/examples/Maps.jsx";
import Register from "./views/examples/Register.jsx";
import Login from "./views/examples/Login.jsx";
import Tables from "./views/examples/Tables.jsx";
import Icons from "./views/examples/Icons.jsx";

var routes = [
    {
        path: "/index",
        name: "Recent Questions",
        icon: "ni ni-bullet-list-67 text-gray-dark",
        component: Index,
        layout: "/admin"
    },
    {
        path: "/tables",
        name: "Courses",
        icon: "ni ni-books text-gray-dark",
        component: Tables,
        layout: "/admin"
    },
    {
        path: "/user-profile",
        name: "User Profile",
        icon: "ni ni-single-02 text-gray-dark",
        component: Profile,
        layout: "/admin"
    },
    {
        path: "/icons",
        name: "Icons",
        icon: "ni ni-planet text-gray-dark",
        component: Icons,
        layout: "/admin"
    },
    {
        path: "/login",
        name: "Login",
        icon: "ni ni-key-25 text-gray-dark",
        component: Login,
        layout: "/auth"
    },
    {
        path: "/register",
        name: "Register",
        icon: "ni ni-circle-08 text-gray-dark",
        component: Register,
        layout: "/auth"
    }
];
export default routes;
