import { useState } from "react";
import { View, Text, TextInput, TouchableOpacity, Image } from "react-native";

import { icons } from "../constants";

const SearchImput = ({
  title,
  value,
  placeholder,
  handleChangeText,
  otherStyles,
  ...props
}) => {
  const [showPassword, setShowPassword] = useState(false);

  return (
      <View className="w-full h-16 px-4 bg-gray-100 rounded-2xl border-2 border-black-200 focus:border-secondary flex flex-row items-center space-x-4 m">
        <TextInput
          className="text-base mb-3 text-black flex-1 font-pregular"
          value={value}
          placeholder="Pesquise por produtos..."
          placeholderTextColor="#7B7B8B"
          onChangeText={handleChangeText}
          secureTextEntry={title === "Password" && !showPassword}
          {...props}
        />

        {title === "Password" && (
          <TouchableOpacity onPress={() => setShowPassword(!showPassword)}>
            <Image
              source={!showPassword ? icons.eye : icons.eyeHide}
              className="w-6 h-6"
              resizeMode="contain"
            />
          </TouchableOpacity>
        )}

        <TouchableOpacity>
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

export default SearchImput;
