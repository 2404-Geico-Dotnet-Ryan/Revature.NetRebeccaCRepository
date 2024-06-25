import { createContext } from "react";
import { User } from "../model/User";

export const UserContext = createContext<User | undefined> (undefined);

/*
get notes from his files when he pushes
*/ 