import { IDirector } from "./IDirector";
import { IGenre } from "./IGenre";
import { IScreenwriter } from "./IScreenwrite";

export interface IMovie {
    id: number;
    title: string;
    releaseYear: string;
    duration: number;
    classification: number;
    stillImage: string;
    poster: string;
    trailer: string;
    sinopse: string;
    directors: IDirector[];
    genres: IGenre[];
    screenwriter: IScreenwriter[];
}

