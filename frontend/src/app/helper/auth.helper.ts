// auth.helper.ts

function base64UrlDecode(str: string): string {
    str = str.replace(/-/g, '+').replace(/_/g, '/');
    while (str.length % 4) {
        str += '=';
    }
    return atob(str);
}

export const setToken = (token: string): void => {
    window.localStorage.setItem('local-user-Token', token);
}

export const setId = (id: string): void => {
    window.localStorage.setItem('local-user-Id', id);
}

export const getToken = (): string | null => {
    return window.localStorage.getItem('local-user-Token');
}

export const getId = (): string | null => {
    return window.localStorage.getItem('local-user-Id');
}

export const getPayLoad = (): any => {
    const token = getToken();
    // console.log(token);
    if (!token) return;
    const splitToken = token.split('.');
    if (splitToken.length !== 3) return;
    return JSON.parse(base64UrlDecode(splitToken[1]));
}

export const userIsAuthenticated = (): boolean => {
    const payload = getPayLoad();
    if (!payload) return false;
    const currentTime = Math.round(Date.now() / 1000);
    return currentTime < payload.exp;
}

export const userIsOwner = (item: any): boolean => {
    const payload = getPayLoad();
    if (!payload) return false;
    return payload.userId === item.createdBy;
}
