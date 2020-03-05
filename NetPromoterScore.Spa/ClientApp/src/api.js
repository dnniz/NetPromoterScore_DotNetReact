const BASE_URL = "../../api";

async function callApi(endpoint, baseUrl, options = {}) {
  options.headers = {
    "Content-Type": "application/json",
    Accept: "application/json"
  };

  const url = baseUrl + endpoint;
  const response = await fetch(url, options);
  const data = await response.json();

  return data;
}

const api = {
  users: {
    listProfiles() {
      return callApi(`/users/profiles`, BASE_URL);
    },
    create(user) {
      return callApi(`/users`, BASE_URL, {
        method: "POST",
        body: JSON.stringify(user)
      });
    },
    login(user) {
      return callApi(`/users/login`, BASE_URL, {
        method: "POST",
        body: JSON.stringify(user)
      });
    }
  },
  survey: {
    create(valueSelected) {
      return callApi(`/survey`, BASE_URL, {
        method: "POST",
        body: JSON.stringify(valueSelected)
      });
    }
  },
  result: {
    getNPS() {
      return callApi(`/result`, BASE_URL);
    }
  }
};

export default api;
