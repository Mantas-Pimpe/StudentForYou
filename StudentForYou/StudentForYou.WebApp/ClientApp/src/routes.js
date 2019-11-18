
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
        icon: "ni ni-bullet-list-67 text-red",
        component: Index,
        layout: "/admin"
    },
    {
        path: "/tables",
        name: "Courses",
        icon: "ni ni-books text-red",
        component: Tables,
        layout: "/admin"
    },
    {
        path: "/user-profile",
        name: "User Profile",
        icon: "ni ni-single-02 text-red",
        component: Profile,
        layout: "/admin"
    },
    {
        path: "/icons",
        name: "Icons",
        icon: "ni ni-planet text-red",
        component: Icons,
        layout: "/admin"
    },
    {
        path: "/login",
        name: "Login",
        icon: "ni ni-key-25 text-red",
        component: Login,
        layout: "/auth"
    },
    {
        path: "/register",
        name: "Register",
        icon: "ni ni-circle-08 text-red",
        component: Register,
        layout: "/auth"
    }
];
export default routes;
