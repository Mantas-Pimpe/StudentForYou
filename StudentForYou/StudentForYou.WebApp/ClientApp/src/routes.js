
import Index from "./views/Index.jsx";
import Profile from "./views/examples/Profile.jsx";
import Register from "./views/examples/Register.jsx";
import Login from "./views/examples/Login.jsx";
import Courses from "./views/Courses.jsx";
import Questions from "./views/Questions.jsx";

var routes = [
    {
        path: "/index",
        name: "Recent Questions",
        icon: "ni ni-bullet-list-67 text-gray-dark",
        component: Questions,
        layout: "/admin"
    },
    {
        path: "/courses",
        name: "Courses",
        icon: "ni ni-books text-gray-dark",
        component: Courses,
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
