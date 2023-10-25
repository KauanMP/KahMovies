
import axios from 'axios';
import { useState } from 'react';
import { useQuery } from 'react-query';

const api = axios.create({
    baseURL: "https://localhost:7120/api"
})

export function useFetch<T = unknown>(queryName: string, url: string) {
    const [data, setData] = useState<T | null>(null);

    const { isLoading } = useQuery(queryName, () => {
        api
        .get(url)
        .then((res) => setData(res.data))
        .catch((err) => err)
    }
    )

    return {
        data,
        isLoading
    }
}