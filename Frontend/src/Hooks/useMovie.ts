

export const useMovie = () => {

    const getAllMovie = async () => {
        const headers = {
            "Content-Type": "application/json",
        }

        const requestOptions = {
            method: "GET",
            headers,
        }

        try {
            const res = await fetch("https://localhost:7120/api/Movie", requestOptions)
                .then((res) => res.json()
                    .catch((err) => err))

            return res
        } catch (error) {
            console.log(error)
        }
    }

    return {
        getAllMovie
    }

}

export default useMovie;
