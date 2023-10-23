import { IAuthor } from "./IAuthor";
import { ICategory } from "./ICategory";

export interface IMovie {
    id: number;
    title: string;
    releaseYear: string;
    duration: number;
    classification: number;
    image: string;
    trailer: string;
    sinopse: string;
    authors: IAuthor[];
    categories: ICategory[];
}

