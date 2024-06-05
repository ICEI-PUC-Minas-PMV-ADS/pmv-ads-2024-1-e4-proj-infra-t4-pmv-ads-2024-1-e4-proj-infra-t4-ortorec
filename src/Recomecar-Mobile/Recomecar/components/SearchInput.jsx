import { useState } from "react";
import { View, Text, TextInput, TouchableOpacity, Image, Alert } from "react-native";

import { icons } from "../constants";
import { usePathname, router } from "expo-router";

const SearchInput = ({ initialQuery }) => {
  const pathname = usePathname();
  const [query, setQuery] = useState(initialQuery || "");

  return (
      <View className="w-full h-12 px-4 bg-gray-100 rounded-2xl border-2 border-black-200 focus:border-secondary flex flex-row items-center space-x-4">
        <TextInput
          className="text-base text-black flex-1 font-pregular"
          value={query}
          placeholder="Pesquise por produtos..."
          placeholderTextColor="#7B7B8B"
          onChangeText={(e) => setQuery(e)}
        />

        <TouchableOpacity
          onPress={() => {
            if(!query) {
              return Alert.alert('Missing query', 'Por favor, insira algo para buscar.')
            }

            if(pathname.startsWith('/busca')) router.setParams({ query })
              else router.push(`/busca/${query}`)
          }}
        
        >
            <Image 
                source={icons.search}
                className="w-6 h-6"
                resizeMode="contain"
                tintColor={"#fb00ff"}
            />
        </TouchableOpacity>

      </View>
  );
};

export default SearchInput;
